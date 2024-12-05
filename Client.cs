using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.ComponentModel.DataAnnotations;

namespace TestSystemClient
{
    internal class Client
    {
        private readonly HttpClient m_client;
        private Uri m_serverUri;
        public string ServerAddress { get
            {
                return m_serverUri.Host;
            }

            set
            {
                if (!value.StartsWith("http:") && !value.StartsWith("https:"))
                    m_serverUri = new Uri("http://" + value);
                else
                    m_serverUri = new Uri(value);
            }
        }

        private string m_sessionKey;

        public Client()
        {
            m_client = new HttpClient();
            m_serverUri = new Uri("http://localhost:8080");
        }

        public bool Register(string login, string email, string password)
        {
            JsonObject request_obj = new JsonObject();

            request_obj.Add("login", login);
            request_obj.Add("email", email);
            request_obj.Add("password", password);

            byte[] bytes = JsonSerializer.SerializeToUtf8Bytes(request_obj);

            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(m_serverUri, "api/register");
            request.Content = new ByteArrayContent(bytes);
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            HttpResponseMessage response = m_client.Send(request);
            if (!response.IsSuccessStatusCode)
                return false;

            return true;
        }

        public bool Login(string username, string password)
        {
            JsonObject request_obj = new JsonObject();

            request_obj.Add("login", username);
            request_obj.Add("password", password);

            byte[] bytes = JsonSerializer.SerializeToUtf8Bytes(request_obj);

            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = HttpMethod.Post;
            request.RequestUri = new Uri(m_serverUri, "api/login");
            request.Content = new ByteArrayContent(bytes);
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

            HttpResponseMessage response = m_client.Send(request);
            if (!response.IsSuccessStatusCode)
                return false;

            JsonDocument response_doc = JsonDocument.Parse(response.Content.ReadAsStream());
            JsonObject? response_obj = response_doc.Deserialize<JsonObject>();
            if (response_obj != null)
            {
                JsonNode? valType = response_obj["response_type"];
                if (valType == null)
                    return false;
                if (valType.GetValue<string>().CompareTo("SESSION_KEY") != 0)
                    return false;

                JsonNode? valSessionKey = response_obj["sessionKey"];
                if (valSessionKey != null)
                {
                    m_sessionKey = valSessionKey.GetValue<string>();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }
    
        public bool Logout()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            request.Method = HttpMethod.Get;
            request.RequestUri = new Uri(m_serverUri, "api/logout");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", m_sessionKey);

            HttpResponseMessage response = m_client.Send(request);
            if (!response.IsSuccessStatusCode)
                return false;
            return true;
        }
    }
}

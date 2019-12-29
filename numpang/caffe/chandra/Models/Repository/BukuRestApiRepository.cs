using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using RestSharp;

namespace chandra.Models.Repository
{
    class BukuRestApiRepository
    {
        public List<User> ReadAll()
        {
            string URI = "http://ipaddress";
            string endPoint = "/users";

            var client = new RestClient(URI);

            var request = new RestRequest(endPoint, Method.GET);

            var response = client.Execute<List<User>>(request);

            return response.Data;
        }

        public List<User> ReadbyRole(string role)
        {
            string URI = "http://ipaddress";
            string endPoint = "/UsersRole";

            var client = new RestClient(URI);

            var request = new RestRequest(endPoint, Method.GET);

            var response = client.Execute<List<User>>(request);

            return response.Data;
        }

        public List<User> ReadbyUsername(string name)
        {
            string URI = "http://ipaddress";
            string endPoint = "/username";

            var client = new RestClient(URI);

            var request = new RestRequest(endPoint, Method.GET);

            var response = client.Execute<List<User>>(request);

            return response.Data;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.CognitoIdentity;
using Amazon.SimpleDB;
using Amazon.SimpleDB.Model;
using MultiUserApp.Models;
using MultiUserApp.Utils;

namespace MultiUserApp.ViewModels
{
    public class SimpleDBStorage : ISimpleDBStorage
    {
        AmazonSimpleDBClient client;
        string tableName = "TodoAuth";

        public List<Horse> Items { get; private set; }

        public SimpleDBStorage()
        {
            var credentials = new CognitoAWSCredentials(
                                  Constants.COGNITO_IDENTITY_POOL_ID,
                                  Constants.COGNITO_REGION);
            var config = new AmazonSimpleDBConfig();
            config.RegionEndpoint = Constants.SIMPLEDB_REGION;
            client = new AmazonSimpleDBClient(credentials, config);

            Items = new List<Horse>();
            SetupDomain();
        }

        async Task SetupDomain()
        {
            var domainExists = await IsExistingDomain();
            if (!domainExists)
            {
                await CreateDomain();
            }
        }

        async Task<bool> IsExistingDomain()
        {
            try
            {
                var response = await client.ListDomainsAsync(new ListDomainsRequest());
                foreach (var domain in response.DomainNames)
                {
                    if (domain == tableName)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
            return false;
        }

        async Task CreateDomain()
        {
            try
            {
                await client.CreateDomainAsync(new CreateDomainRequest { DomainName = tableName });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
        }

        List<Amazon.SimpleDB.Model.Attribute> ToSimpleDBAttributes(Horse item)
        {
            return new List<Amazon.SimpleDB.Model.Attribute>() {
                new Amazon.SimpleDB.Model.Attribute () {
                    Name = "Name",
                    Value = item.Name
                },
                new Amazon.SimpleDB.Model.Attribute () {
                    Name = "Color",
                    Value = item.Color
                },
                new Amazon.SimpleDB.Model.Attribute () {
                    Name = "Height",
                    Value = item.Height.ToString ()
                },
                new Amazon.SimpleDB.Model.Attribute () {
                    Name = "Weight",
                    Value = item.Weight.ToString ()
                },
				
                // The users email address is used to identify data in SimpleDB
				new Amazon.SimpleDB.Model.Attribute () {
                    Name = "User",
                    Value = App.User.Email
                }
            };
        }

        public async Task<List<Horse>> RefreshDataAsync()
        {
            throw new NotImplementedException();

        }

        public async Task SaveTodoItemAsync(Horse item)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteTodoItemAsync(Horse id)
        {
            throw new NotImplementedException();
        }
    }
}

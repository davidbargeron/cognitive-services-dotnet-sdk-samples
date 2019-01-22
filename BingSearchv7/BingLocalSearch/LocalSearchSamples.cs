namespace bing_search_dotnet.Samples
{
    using System;
    using System.Linq;
    using System.Text;
    using Microsoft.Azure.CognitiveServices.Search;
    using Microsoft.Azure.CognitiveServices.Search.LocalSearch;
    using Microsoft.Azure.CognitiveServices.Search.LocalSearch.Models;
    using Newtonsoft.Json;

    [SampleCollection("LocalSearch")]
    public class LocalSearchSamples
    {
        /* TODO - evidently need Microsoft.Azure.CognitiveServices.Search.LocalSearch package to be published to nuget in order to write our samples??
         
        [Example("This will look up a single local business by name")]
        public static void LocalBusinessLookup(string subscriptionKey)
        {
            var client = new LocalSearchClient(new ApiKeyServiceClientCredentials(subscriptionKey));

            try
            {
                var entityData = client.Entities.Search(query:"Satya Nadella");
                
                if (entityData?.Entities?.Value?.Count > 0)
                {
                    // find the entity that represents the dominant one
                    var mainEntity = entityData.Entities.Value.Where(thing => thing.EntityPresentationInfo.EntityScenario == EntityScenario.DominantEntity).FirstOrDefault();

                    if (mainEntity != null)
                    {
                        Console.WriteLine("Searched for \"Satya Nadella\" and found a dominant entity with this description:");
                        Console.WriteLine(mainEntity.Description);
                    }
                    else
                    {
                        Console.WriteLine("Couldn't find main entity Satya Nadella!");
                    }
                }
                else
                {
                    Console.WriteLine("Didn't see any data..");
                }
            }
            catch (ErrorResponseException ex)
            {
                Console.WriteLine("Encountered exception. " + ex.Message);
            }
        }

        [Example("This will look up a single restaurant (john howie bellevue) and print out its phone number")]
        public static void RestaurantLookup(string subscriptionKey)
        {
            var client = new EntitySearchAPI(new ApiKeyServiceClientCredentials(subscriptionKey));

            try
            {
                var entityData = client.Entities.Search(query: "john howie bellevue");

                if (entityData?.Places?.Value?.Count > 0)
                {
                    // Some local entities will be places, others won't be. Depending on the data you want, try to cast to the appropriate schema
                    // In this case, the item being returned is technically a Restaurant, but the Place schema has the data we want (telephone)
                    var restaurant = entityData.Places.Value.FirstOrDefault() as Place;

                    if (restaurant != null)
                    {
                        Console.WriteLine("Searched for \"John Howie Bellevue\" and found a restaurant with this phone number:");
                        Console.WriteLine(restaurant.Telephone);
                    }
                    else
                    {
                        Console.WriteLine("Couldn't find a place!");
                    }
                }
                else
                {
                    Console.WriteLine("Didn't see any data..");
                }
            }
            catch (ErrorResponseException ex)
            {
                Console.WriteLine("Encountered exception. " + ex.Message);
            }
        }

        [Example("This will look up a list of restaurants (seattle restaurants) and present their names and phone numbers")]
        public static void MultipleRestaurantLookup(string subscriptionKey)
        {
            var client = new EntitySearchAPI(new ApiKeyServiceClientCredentials(subscriptionKey));

            try
            {
                var restaurants = client.Entities.Search(query: "seattle restaurants");

                if (restaurants?.Places?.Value?.Count > 0)
                {
                    // get all the list items that relate to this query
                    var listItems = restaurants.Places.Value.Where(thing => thing.EntityPresentationInfo.EntityScenario == EntityScenario.ListItem).ToList();

                    if (listItems?.Count > 0)
                    {
                        var sb = new StringBuilder();

                        foreach (var item in listItems)
                        {
                            var place = item as Place;

                            if (place == null)
                            {
                                Console.WriteLine("Unexpectedly found something that isn't a place named \"{0}\"", item.Name);
                                continue;
                            }

                            sb.AppendFormat(",{0} ({1}) ", place.Name, place.Telephone);
                        }

                        Console.WriteLine("Ok, we found these places: ");
                        Console.WriteLine(sb.ToString().Substring(1));
                    }
                    else
                    {
                        Console.WriteLine("Couldn't find any relevant results for \"seattle restaurants\"");
                    }
                }
                else
                {
                    Console.WriteLine("Didn't see any data..");
                }
            }
            catch (ErrorResponseException ex)
            {
                Console.WriteLine("Encountered exception. " + ex.Message);
            }
        }

        [Example("This triggers a bad request and shows how to read the error response")]
        public static void Error(string subscriptionKey)
        {
            var client = new EntitySearchAPI(new ApiKeyServiceClientCredentials(subscriptionKey));

            try
            {
                var entityData = client.Entities.Search(query: "Satya Nadella", market: "no-ty");
            }
            catch (ErrorResponseException ex)
            {
                // The status code of the error should be a good indication of what occurred. However, if you'd like more details, you can dig into the response.
                // Please note that depending on the type of error, the response schema might be different, so you aren't guaranteed a specific error response schema.
                Console.WriteLine("Exception occurred, status code {0} with reason {1}.", ex.Response.StatusCode, ex.Response.ReasonPhrase);

                // if you'd like more descriptive information (if available), attempt to parse the content as an ErrorResponse
                var issue = JsonConvert.DeserializeObject<ErrorResponse>(ex.Response.Content);

                if (issue != null && issue.Errors?.Count > 0)
                {
                    if (issue.Errors[0].SubCode == ErrorSubCode.ParameterInvalidValue)
                    {
                        Console.WriteLine("Turns out the issue is parameter \"{0}\" has an invalid value \"{1}\". Detailed message is \"{2}\"", issue.Errors[0].Parameter, issue.Errors[0].Value, issue.Errors[0].Message);
                    }
                }
            }
        }

        */
    }
}

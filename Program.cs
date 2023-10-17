using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoTraining.Models;
using System.Xml.Linq;

var mongoURL = new MongoUrl("mongodb+srv://shrikant:cyb123456@cluster0.nma8moq.mongodb.net/?retryWrites=true&w=majority");
#region MyRegion

//var client = new MongoClient(mongoURL);

//var dbList = client.ListDatabases().ToList();

//Console.WriteLine("The list of DBs: ");

//foreach (var db in dbList)
//{
//    Console.WriteLine(db);
//}

//var document = new BsonDocument
//{
//   { "account_id", "MDB829001337" },
//   { "account_holder", "Linus Torvalds" },
//   { "account_type", "checking" },
//   { "balance", 50352434 }
//};

////var accountsCollection = database.GetCollection<Account>("account");

//var newAccount = new Account
//{
//    AccountId = "MDB829001337",
//    AccountHolder = "Linus Torvalds",
//    AccountType = "checking",
//    Balance = 50352434
//};
#endregion
BsonSerializer.RegisterSerializer(new DecimalSerializer(BsonType.Decimal128));

var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
//var settings = MongoClientSettings.FromConnectionString(connectionString);
var client = new MongoClient(mongoURL);
var database = client.GetDatabase("bank");
var accountsCollection = database.GetCollection<Account>("accounts");
var sampleDocument = new Account
{
    AccountId = "MDB829001338",
    AccountHolder = "Shrikant Chate",
    AccountType = "checking",
    Balance = 50352435
};
#region Find
//var accounts = await accountsCollection.FindAsync(
//    a=> a.AccountId.Length>0);
//var account = accounts.First();
//Console.WriteLine(account.AccountHolder);
#endregion

#region Update
//var filter = Builders<Account>
//   .Filter
//   .Eq(a => a.AccountId, "MDB829001337");

//var update = Builders<Account>
//   .Update
//   .Set(a => a.Balance, 5000);

//var result = accountsCollection.UpdateOne(filter, update);

//Console.WriteLine(result.ModifiedCount);
#endregion

#region Create
//accountsCollection.InsertOne(sampleDocument);
#endregion

#region Delete
//var accountCollection =
//  database.GetCollection<Account>("Account");

//var result = accountsCollection
//   .DeleteOne(a => a.AccountId == "MDB829001338");

//Console.WriteLine(result.DeletedCount);
#endregion

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoTraining.Models;

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



// TODO: Create an expression which inserts a single document into the `accounts` collection below:
accountsCollection.InsertOne(sampleDocument);
// TODO: Create an expression which inserts a single document into the `accounts` collection below:

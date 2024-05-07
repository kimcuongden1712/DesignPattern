using FactoryMethod;

var client = new Client();
client.Deliver(new CheapShipping());
client.Deliver(new RegularShipping());
client.Deliver(new FastShipping());
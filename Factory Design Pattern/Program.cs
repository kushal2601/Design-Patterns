using FactorDesignPattern;

IDocumentFactory factory = new DocumentFactory();
var document = factory.CreateDocument("-lbhj");
document.GetInformation();
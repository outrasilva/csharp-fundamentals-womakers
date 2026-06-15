// Module 5 - Arrays and foreach
// Concepts: array declaration, index (zero-based), Length property, foreach, string.StartsWith()

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

Console.WriteLine($"There are {orderIDs.Length} orders to check.");

// foreach + if to filter orders starting with "B"
foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}
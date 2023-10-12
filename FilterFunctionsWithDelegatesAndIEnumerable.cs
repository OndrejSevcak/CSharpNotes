//input data
var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

//filter without delegate
var result = SelectEven(data);  //the SelectEven method does not get executed here because of the use of yield return
Console.WriteLine(String.Join(",", result));    //is executes when the result is called

//with delegate
var resultFromFilterNumbers = FilterNumbers(data, IsEven);
Console.WriteLine(String.Join(",", resultFromFilterNumbers));

//generic type with delegate
var resultFromGeneric = FilterAnything(data, IsEven);
Console.WriteLine(String.Join(",", resultFromGeneric));

//generic type with lambda
var oddNumbersFromLambda = FilterAnything(data, item => item % 2 == 1);
Console.WriteLine(String.Join(",", oddNumbersFromLambda));

//--------------------------------------------------------------------------------------------------------------------

//without delegae using yield return
IEnumerable<int> SelectEven(int[] data)
{
    foreach (var item in data)
    {
        if (item % 2 == 0)
        {
            yield return item;
        }
    }
}

//filter function for filterNumbers methos
static bool IsEven(int number)
{
    return number % 2 == 0;
}


//filter method for numbers with delegate parametr for the filter function
IEnumerable<int> FilterNumbers(IEnumerable<int> input, Func<int, bool> filterFunction)
{
    foreach (var item in input)
    {
        if (filterFunction(item)) yield return item;
    }
}


//generic type filter function - not limited for numbers(int)
IEnumerable<T> FilterAnything<T>(IEnumerable<T> input, Func<T, bool> function)
{
    foreach (var item in input)
    {
        if (function(item)) yield return item;
    }
}


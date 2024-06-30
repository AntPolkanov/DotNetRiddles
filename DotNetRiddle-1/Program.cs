
var before = GC.GetAllocatedBytesForCurrentThread();
await GetNumber();
var after = GC.GetAllocatedBytesForCurrentThread();
//
Console.WriteLine($"Bytes allocated: {after - before}");


static Task<int> GetNumber()
{
    return Task.FromResult(0);
}

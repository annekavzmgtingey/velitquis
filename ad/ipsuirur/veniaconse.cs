var queryStream1 = GetQueryStream1();
var queryStream2 = GetQueryStream2();
var queryStream3 = GetQueryStream3();

var mergedStream = AsyncAlgorithms.Merge(queryStream1, queryStream2, queryStream3);

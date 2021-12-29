// See https://aka.ms/new-console-template for more information

using AdapterPattern;

PolarGraph polarGraph = new PolarGraph();   
IGraph graph = new PolarGraphAdapter(polarGraph);

graph.Point(3, 4);


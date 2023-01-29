
using CompositePattern;

var shelf1 = new Shelf();
var shelf2 = new Shelf();
var shelf3 = new Shelf();

shelf1.AddContainers(shelf2, shelf3);
var box1 = new Box(10);
var box2 = new Box(20);
var box3 = new Box(15);
var box4 = new Box(30);

shelf2.AddContainers(box1, box2);
shelf3.AddContainers(box3, box4);
var drawer = new GraphDrawer();
shelf1.Accept(drawer);
Console.WriteLine(drawer.GetGraph().ToString());

Console.ReadLine();

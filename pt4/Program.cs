using pt4;
using Barrier = pt4.Barrier;

Barrier barrier = new Barrier();
Barrier.Event1 += barrier.Close;
Barrier.Event2 += barrier.Open;

for (int i = 0; i < 10; i++)
{
    Man man = new Man("Человек " + i);
    Barrier.Event1 += man.Stand;
    Barrier.Event2 += man.Go;
    barrier.MoveThrough(i);
}
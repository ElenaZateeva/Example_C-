int distance = 1000, firstFriendSpeed = 1,
    dogSpeed = 5, secondFriendSpeed = 2,
    friend = 2, count = 0;
 int timeA = 0;
while (distance > 10)
{
    if (friend == 1)
    {
        timeA = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        timeA = distance / (secondFriendSpeed + dogSpeed);
        friend = 1; 
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * timeA;
    count++;
}
Console.Write("Собака пробежит ", count, " раз.");
Console.Write(count);
Console.WriteLine(" раз.");
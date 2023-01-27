int count = 0;
int distance = new Random().Next(1000, 1000001);
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;

System.Console.WriteLine($"Дистанция между друзьями {distance} метров");

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }
    else
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
}
System.Console.WriteLine($"Собака пробежала между друзьями {count} раз");
// System.Console.WriteLine("Собака пробежала между друзьями " + count + " раз");

﻿int count = 0, distance = 10000,
    firstFriendSpeed = 1,
    secondFriendSpeed = 2,dogSpeed = 5,
    time = 0;
int friend = 2;

while(distance > 10)
{
   if(friend == 1) 
   {
    time = distance / (firstFriendSpeed + dogSpeed);
    friend = 2;
   }

   else
   {
    time = distance / (secondFriendSpeed + dogSpeed);
    friend = 1;
   }
   distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
   count = count +1;
}

Console.WriteLine(count);
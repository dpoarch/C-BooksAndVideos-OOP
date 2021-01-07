## C#-BooksAndVideos-OOP

-Update/restore required packages from Nugetpackage manager\
-Run the following test on ProcessTest.cs to check the function results

## System Description
BooksAndVideos is an e-commerce shop where customers can buy books and videos.
Customers can also order memberships for the book club, the video club or for both clubs.
Purchase Order can have books, videos and/or club membership subscriptions. Each order
has ID, Customer ID and Total Price as well as Item Line for each product or membership
purchased.

Order Example:\
ID: 3344656\
Total Price: 48.50\
Customer ID: 4567890\

Item Lines:\
Video "Transformers"\
Book "Harry Potter and the Goblet of Fire"\
Book Club Membership\
Several Order Rules are applied when order is processed.


OR1: if order contains any memberships, they have to be activated in the customer account
immediately.\
OR2: if order contains any physical products (book, video) a shipping slip has to be generated.\
OR3: if order contains a “Mission Impossible 3 ” video then “Mission Impossible 2” video is
added to the purchase order as a free item.\
OR4: if order contains books, and the customer has book membership or bought one then 5
points are added to the customer account for each book.\
OR5: if order contains videos, and the customer has video club membership or bought one then
5 points are added to the customer account for each video.

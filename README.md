## C#-BooksAndVideos-OOP

-Update/restore required packages from Nugetpackage manager&nbsp;
-Run the following test on ProcessTest.cs to check the function results&nbsp;

## System Description
BooksAndVideos is an e-commerce shop where customers can buy books and videos.
Customers can also order memberships for the book club, the video club or for both clubs.
Purchase Order can have books, videos and/or club membership subscriptions. Each order
has ID, Customer ID and Total Price as well as Item Line for each product or membership
purchased.

Order Example:&nbsp;
ID: 3344656&nbsp;
Total Price: 48.50&nbsp;
Customer ID: 4567890&nbsp;

Item Lines:&nbsp;
Video "Transformers"&nbsp;
Book "Harry Potter and the Goblet of Fire"&nbsp;
Book Club Membership&nbsp;
Several Order Rules are applied when order is processed.&nbsp;


OR1: if order contains any memberships, they have to be activated in the customer account
immediately.&nbsp;
OR2: if order contains any physical products (book, video) a shipping slip has to be generated.&nbsp;
OR3: if order contains a “Mission Impossible 3 ” video then “Mission Impossible 2” video is
added to the purchase order as a free item.&nbsp;
OR4: if order contains books, and the customer has book membership or bought one then 5
points are added to the customer account for each book.&nbsp;
OR5: if order contains videos, and the customer has video club membership or bought one then
5 points are added to the customer account for each video.&nbsp;

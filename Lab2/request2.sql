select firstname, lastname, 
from guests as G inner join Bookings B
on G.id = B.guestId
where startdate between '2018-03-01' and '2018-05-01';
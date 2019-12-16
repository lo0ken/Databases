WITH today AS (
	select * 
	from bookings
	where bookings.startdate = '2019-06-13'
)
SELECT G.Id, G.firstname
from Guests G inner join Bookings B 
	on G.Id = B.guestId
	where B.startdate in (select id from today);
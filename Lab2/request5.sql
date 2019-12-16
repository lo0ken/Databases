with notBeBooked as (
	select rooms.Id
	from rooms left outer join bookings
	on rooms.Id = bookings.roomId
	where bookings.roomId IS NULL
)

select id, cost
from rooms as R
where R.Id in (select * from notBeBooked)
AND EXISTS (select * from notBeBooked);
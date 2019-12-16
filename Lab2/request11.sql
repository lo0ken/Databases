with bookDays(bId, days) as (
	select B.id, (b.finishdate - b.startdate)
	from bookings as B
	group by B.id
),
maxDays(cnt) as (
	select max(days)
	from bookDays
)
select *
into TEMP LongestBookings
from bookings as B
where (b.finishdate - b.startdate) in (select * from maxDays);
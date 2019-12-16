select AVG(TotalPrice::numeric) as AverageCost,
SUM(TotalPrice) / Count(id) as calc

FROM (
	select B.id, SUM((B.finishdate - B.startdate) * R.cost) as TotalPrice
	from bookings as B inner join rooms as R
	on B.roomId = R.Id
	group by B.id
) as TotalBookings;
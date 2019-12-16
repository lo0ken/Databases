select hotelName, top100Rooms.id, Cost
from (
	select R.Id, HotelId, cost
	from rooms as R
	group by R.Id, HotelId
	order by cost DESC
	limit 100
) as top100Rooms
inner join hotels as H on hotelId = H.id
select hotelName, 
(
	select AVG(cost::numeric)
	from rooms
	where rooms.hotelId = hotels.Id
) as AvgCost,
(
	select MAX(cost)
	from rooms
	where rooms.hotelId = hotels.Id
) as MaxCost
from rooms inner join hotels
on rooms.hotelId = hotels.Id
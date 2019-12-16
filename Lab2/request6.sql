select id, costs, hotelId
from rooms as R
where R.cost > ALL (
	select distinct Rooms.cost
	from rooms
	where Rooms.hotelId = 554
);
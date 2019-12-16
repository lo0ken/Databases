select cityname, cnt
from (
	select cityId, sum(bookingsCount) as cnt
	from (
		select hotelId, sum(cnt) as bookingsCount
		from (
			select B.roomId, count(roomId) as cnt
			from bookings as B
			group by B.roomId
		) as roomCnt
		inner join rooms on roomId = rooms.id
		group by hotelId
	) as hotelCnt
	inner join hotels as H on hotelId = id
	group by cityId
) as booksInCity
inner join cities on cityId = id
order by cnt desc
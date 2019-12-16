select hotelName, 
	CASE
		WHEN AVG(cost::numeric) < 3000 then 'Cheap'
		WHEN AVG(cost::numeric) < 4000 then 'Fair'
		WHEN AVG(cost::numeric) > 4000 then 'Expensive'
		ELSE 'Undefined'
	END

from rooms as R inner join hotels as H
on R.hotelId = H.id
group by hotelName;
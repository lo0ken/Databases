select firstname, lastname, phone,
	CASE date_part('year', B.startdate)
		WHEN date_part('year', current_date) THEN 'This Year'
		WHEN date_part('year', current_date) - 1 THEN 'Last Year'
		ELSE (date_part('year', current_date) - date_part('year', B.startdate))::varchar || ' years ago'
	END

from bookings as B inner join guests as G
on B.guestId = G.id
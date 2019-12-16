insert into hotels
select (
	select max(H.Id)
	from hotels as H
	where H.companyId is NULL
), hotelname, 31, 1
from hotels
where hotelname like '%hotel%'
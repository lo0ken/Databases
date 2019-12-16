select id, cost 
from rooms as R
where R.hotelId in (
	select hotelId
	from hotels inner join companies
	on hotels.companyId = companies.Id
);
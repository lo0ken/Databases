select companyName, count(hotels.id) as hotels
from companies
inner join hotels on hotels.companyId = companies.id
group by companyName
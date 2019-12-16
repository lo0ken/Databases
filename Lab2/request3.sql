select distinct hotelname, companyName
from hotels as H inner join Companies as C
on H.companyId = C.id
where C.companyName LIKE '%Hotels%';
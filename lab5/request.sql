
CREATE  TEMP TABLE hotels_tmp
(
	Id INT NOT NULL,
	HotelName VARCHAR (60) NOT NULL,
	CityId INT NOT NULL,
	CompanyId INT NULL
);


create unlogged table customer_import (doc json);
copy customer_import from 'C:\Users\Public\hotels.json';

insert into hotels_tmp (id, hotelname, cityid, companyid)
select p.*
from customer_import l
  cross join lateral json_populate_record(null::hotels, doc) as p;
 
select * from hotels_tmp;







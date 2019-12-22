/*copy(select row_to_json(hotels)
from hotels)
to 'C:\Users\Public\hotels.json';*/

/*CREATE  TEMP TABLE hotels_tmp
(
	Id INT NOT NULL,
	HotelName VARCHAR (60) NOT NULL,
	CityId INT NOT NULL,
	CompanyId INT NULL
);*/


--select * from json_to_record('{"id":2,"hotelname":"Bed & Breakfast Of Greensburg","cityid":158,"companyid":null}');


/*create unlogged table customer_import (doc json);
copy customer_import from 'C:\Users\Public\hotels.json';*/


insert into hotels_tmp (id, hotelname , cityid , companyid )
select p.* from customer_import l
cross join lateral json_populate_recordset(null::hotels_tmp, doc) as p







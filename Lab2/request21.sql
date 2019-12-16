delete from cities
where id in (
	select C.id
	from cities as C left outer join hotels as H
	on H.cityId = C.id
	where H.Id is null
);
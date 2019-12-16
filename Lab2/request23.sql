with recursive cityy (id, level) as (
	select id, 0 as level
	from hotels as h
	where h.companyId is null
	
	union all
	
	select hotels.id, level + 1
	from hotels
	inner join cityy on hotels.cityId = cityy.id
)
select * from cityy
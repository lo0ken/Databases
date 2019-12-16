WITH moscowId as (
select id from cities
where cities.cityname = 'MOSCOW')

select id, hotelname from hotels
where hotels.cityId in (select * from moscowId);
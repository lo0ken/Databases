UPDATE rooms
SET cost = (
	select AVG(cost::numeric)
	from rooms
)
where rooms.id = 35;
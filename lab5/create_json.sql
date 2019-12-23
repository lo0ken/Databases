copy (
	select row_to_json(hotels)
	from hotels
) to 'C:\Users\Public\hotels.json'
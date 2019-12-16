COPY Guests FROM 'D:\BMSTU\Course3\Databases\Labs\Lab1\guests.txt' (DELIMITER(E'\t'));
COPY Cities FROM 'D:\BMSTU\Course3\Databases\Labs\Lab1\cities.txt' (DELIMITER(E'\t'));

COPY Companies FROM 'D:\BMSTU\Course3\Databases\Labs\Lab1\companies.txt' (DELIMITER(E'\t'));
COPY Hotels FROM 'D:\BMSTU\Course3\Databases\Labs\Lab1\hotels.txt' 
WITH (NULL('0'));

COPY Rooms FROM 'D:\BMSTU\Course3\Databases\Labs\Lab1\rooms.txt' (DELIMITER(E'\t'));
COPY Bookings FROM 'D:\BMSTU\Course3\Databases\Labs\Lab1\bookings.txt' (DELIMITER(E'\t'));

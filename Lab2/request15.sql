select H.hotelName, count(R.id)
from hotels as H inner join rooms as R
on R.hotelId = H.id
group by H.hotelName
having count(R.id) > 20
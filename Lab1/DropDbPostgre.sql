UPDATE pg_database SET datallowconn = 'false' WHERE datname = 'hotels';

SELECT pg_terminate_backend(pg_stat_activity.pid)
FROM pg_stat_activity
WHERE pg_stat_activity.datname = 'hotels' AND pid <> pg_backend_pid();


-- MYSQL
SELECT (SELECT count(*) FROM STATION y) - (SELECT count(*) FROM (SELECT DISTINCT b.city FROM station b) x) z;
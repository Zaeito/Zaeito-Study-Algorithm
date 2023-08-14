-- 코드를 입력하세요
SELECT DISTINCT c1.car_id
FROM car_rental_company_car c1
JOIN car_rental_company_rental_history c2
ON c1.car_id = c2.car_id
WHERE c1.car_type = '세단'
AND c2.start_date LIKE '2022-10%'
ORDER BY c1.car_id DESC;
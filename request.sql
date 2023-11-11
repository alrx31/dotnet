 -- Get all products of selected brand

SELECT 
    p_id AS 'ID',
    b_name AS BRAND,
    c_name AS CATEGORY,
    p_name AS 'NAME',
    p_price AS PRICE,
    p_average_rating AS RATING
FROM product 
JOIN BRAND ON b_id =p_brand_id
JOIN CATEGORY ON c_id = p_category_id
WHERE b_name = 'name';

-- Get all product variations for the selected brand

SELECT 
    pv_id AS 'ID',
    pv_color_id AS COLOR,
    pv_size_id AS 'SIZE',
    p_id AS PRODUCT,
    pv_quantity AS QUANTITY,
    pv__sku AS SKU
FROM product_variant
JOIN product on p_id = pv_product_id
JOIN brand on b_id = p_brand_id
WHERE b_name = 'NAME';


--Select all brands with the number of their products respectively. Order by the number of products.

SELECT
    b_name AS BRAND,
    COUNT(p_id) AS NUMBER_OF_PRODUCTS
FROM brand
JOIN product ON p_brand_id = b_id
GROUP BY b_name
HAVING COUNT(p_id) = 'COUNT';


--Select all brands with the number of their products respectively. Order by the number of products.

SELECT
    p_id AS 'ID',
    p_brand_id AS BRAND,
    p_name AS 'NAME',
    sc_category_id AS CATEGORY,
    sc_section_id AS SECTION
FROM section_category
JOIN product ON p_category_id = sc_category_id
WHERE sc_category_id = 'specific_category_value' OR sc_section_id = 'specific_section_value';


--Get all completed orders with a given product. Order from newest to latest.


SELECT
    o_id AS 'ID',
    ot_status AS 'STATUS',
    ot_updated_at AS 'DATE',
FROM order
JOIN order_transactions ON o_id = ot_o_id
WHERE ot_status = 'STATUS'
ORDER BY ot_updated_at DESC;

--Get all reviews for a given product. Implement this as a viewtable which contains rating, comment and info of a person who left a comment.

SELECT
    r_id AS 'ID',
    p_id AS PRODUCT_ID,
    r_rating AS RAITING,
    r_title AS TITLE,
    r_comment AS COMMENT,
    u_id AS USER_ID,
    u_type AS USER_TYPE,
    u_first_name AS FNAME,
    u_last_name AS LNAME,
    u_phone AS PHONE,
    u_email AS EMAIL
FROM review
JOIN user ON u_id = r_user_id
JOIN product ON p_id = r_product_id
WHERE p_id = 'PRODUCT_ID';



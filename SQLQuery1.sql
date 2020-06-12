SELECT
eq.*,e.emp_name my
FROM employee e,equipment eq
WHERE e.emp_no=eq.equ_emp AND  e.emp_name=N'许树雄'
Create function Doanhthu_tung_thang
(
	@year int,
	@month int  
)
returns table as return
select Item.item_id, item_name,tong,(item_price_out*Tong) as doanhthu
from Item,(select item_id,sum(quantity) as tong
		from Lineitem,Orders
		where year(order_date) = 2022 and MONTH(order_date)=1 and Lineitem.order_id=Orders.order_id
		group by item_id) as dt_thang
where Item.item_id=dt_thang.item_id
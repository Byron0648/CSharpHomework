<?xml version="1.0" encoding="GB2312" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="/">
	<html>
	<head>
	<title>Orders</title>
	</head>
	<body>
	<ul>
	<xsl:for-each select="OrderService/orders/Order">
	<br/><br/>
	<li>订单号：
	<xsl:value-of select="OrdNum" />
	</li>
	<li>客户名：
	<xsl:value-of select="BuyerName" />
	</li>
	<li>手机号：
	<xsl:value-of select="BuyerPhoneNum" />
	</li>
	<xsl:for-each select="orderDetails/OrderDetail">
	<li>--------
	<ul>
	<li>商品:
	<xsl:value-of select="GoodsName" />
	</li>
	<li>价格:
	<xsl:value-of select="GoodsPrice" />
	</li>
	<li>数量：
	<xsl:value-of select="GoodsNum" />
	</li>
	<li>产地:
	<xsl:value-of select="SourcePlace" />
	</li>
	</ul>
	</li>
	</xsl:for-each>
	</xsl:for-each>
	</ul>
	</body>
	</html>
</xsl:template>
</xsl:stylesheet>
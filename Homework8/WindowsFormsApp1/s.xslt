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
	<li>�����ţ�
	<xsl:value-of select="OrdNum" />
	</li>
	<li>�ͻ�����
	<xsl:value-of select="BuyerName" />
	</li>
	<li>�ֻ��ţ�
	<xsl:value-of select="BuyerPhoneNum" />
	</li>
	<xsl:for-each select="orderDetails/OrderDetail">
	<li>--------
	<ul>
	<li>��Ʒ:
	<xsl:value-of select="GoodsName" />
	</li>
	<li>�۸�:
	<xsl:value-of select="GoodsPrice" />
	</li>
	<li>������
	<xsl:value-of select="GoodsNum" />
	</li>
	<li>����:
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
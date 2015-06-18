<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" encoding="utf-8" />
  
  <xsl:param name="RequestRq" />
  <xsl:param name="RequestId" />
  
  <xsl:template match="*">
    <xsl:processing-instruction name="qbxml">version="13.0"</xsl:processing-instruction>   
    <QBXML>
      <QBXMLMsgsRq onError="stopOnError">
        <xsl:element name="{$RequestRq}">
          <xsl:attribute name="requestID">
            <xsl:value-of select="$RequestId" />
          </xsl:attribute>
          <xsl:copy-of select="/*" />
        </xsl:element>
      </QBXMLMsgsRq>
    </QBXML>
  </xsl:template>
</xsl:stylesheet>
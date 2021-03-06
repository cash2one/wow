#ifndef _CkHttp_H
#define _CkHttp_H
#include "Chilkat_C.h"

HCkHttp CkHttp_Create(void);
void CkHttp_Dispose(HCkHttp handle);
void CkHttp_getAccept(HCkHttp handle, HCkString retval);
void CkHttp_putAccept(HCkHttp handle, const char *newVal);
void CkHttp_getAcceptCharset(HCkHttp handle, HCkString retval);
void CkHttp_putAcceptCharset(HCkHttp handle, const char *newVal);
void CkHttp_getAcceptLanguage(HCkHttp handle, HCkString retval);
void CkHttp_putAcceptLanguage(HCkHttp handle, const char *newVal);
BOOL CkHttp_getAutoAddHostHeader(HCkHttp handle);
void CkHttp_putAutoAddHostHeader(HCkHttp handle, BOOL newVal);
long CkHttp_getConnectTimeout(HCkHttp handle);
void CkHttp_putConnectTimeout(HCkHttp handle, long newVal);
void CkHttp_getConnection(HCkHttp handle, HCkString retval);
void CkHttp_putConnection(HCkHttp handle, const char *newVal);
void CkHttp_getCookieDir(HCkHttp handle, HCkString retval);
void CkHttp_putCookieDir(HCkHttp handle, const char *newVal);
long CkHttp_getDefaultFreshPeriod(HCkHttp handle);
void CkHttp_putDefaultFreshPeriod(HCkHttp handle, long newVal);
BOOL CkHttp_getFetchFromCache(HCkHttp handle);
void CkHttp_putFetchFromCache(HCkHttp handle, BOOL newVal);
void CkHttp_getFinalRedirectUrl(HCkHttp handle, HCkString retval);
BOOL CkHttp_getFollowRedirects(HCkHttp handle);
void CkHttp_putFollowRedirects(HCkHttp handle, BOOL newVal);
long CkHttp_getFreshnessAlgorithm(HCkHttp handle);
void CkHttp_putFreshnessAlgorithm(HCkHttp handle, long newVal);
long CkHttp_getHeartbeatMs(HCkHttp handle);
void CkHttp_putHeartbeatMs(HCkHttp handle, long newVal);
BOOL CkHttp_getIgnoreMustRevalidate(HCkHttp handle);
void CkHttp_putIgnoreMustRevalidate(HCkHttp handle, BOOL newVal);
BOOL CkHttp_getIgnoreNoCache(HCkHttp handle);
void CkHttp_putIgnoreNoCache(HCkHttp handle, BOOL newVal);
long CkHttp_getLMFactor(HCkHttp handle);
void CkHttp_putLMFactor(HCkHttp handle, long newVal);
void CkHttp_getLastContentType(HCkHttp handle, HCkString retval);
void CkHttp_getLastErrorHtml(HCkHttp handle, HCkString retval);
void CkHttp_getLastErrorText(HCkHttp handle, HCkString retval);
void CkHttp_getLastErrorXml(HCkHttp handle, HCkString retval);
void CkHttp_getLastHeader(HCkHttp handle, HCkString retval);
void CkHttp_getLastModDate(HCkHttp handle, HCkString retval);
void CkHttp_getLastResponseHeader(HCkHttp handle, HCkString retval);
long CkHttp_getLastStatus(HCkHttp handle);
void CkHttp_getLogin(HCkHttp handle, HCkString retval);
void CkHttp_putLogin(HCkHttp handle, const char *newVal);
long CkHttp_getMaxConnections(HCkHttp handle);
void CkHttp_putMaxConnections(HCkHttp handle, long newVal);
long CkHttp_getMaxFreshPeriod(HCkHttp handle);
void CkHttp_putMaxFreshPeriod(HCkHttp handle, long newVal);
unsigned long CkHttp_getMaxResponseSize(HCkHttp handle);
void CkHttp_putMaxResponseSize(HCkHttp handle, unsigned long newVal);
long CkHttp_getMaxUrlLen(HCkHttp handle);
void CkHttp_putMaxUrlLen(HCkHttp handle, long newVal);
BOOL CkHttp_getMimicFireFox(HCkHttp handle);
void CkHttp_putMimicFireFox(HCkHttp handle, BOOL newVal);
BOOL CkHttp_getMimicIE(HCkHttp handle);
void CkHttp_putMimicIE(HCkHttp handle, BOOL newVal);
long CkHttp_getMinFreshPeriod(HCkHttp handle);
void CkHttp_putMinFreshPeriod(HCkHttp handle, long newVal);
BOOL CkHttp_getNtlmAuth(HCkHttp handle);
void CkHttp_putNtlmAuth(HCkHttp handle, BOOL newVal);
long CkHttp_getNumCacheLevels(HCkHttp handle);
void CkHttp_putNumCacheLevels(HCkHttp handle, long newVal);
long CkHttp_getNumCacheRoots(HCkHttp handle);
void CkHttp_getPassword(HCkHttp handle, HCkString retval);
void CkHttp_putPassword(HCkHttp handle, const char *newVal);
void CkHttp_getProxyDomain(HCkHttp handle, HCkString retval);
void CkHttp_putProxyDomain(HCkHttp handle, const char *newVal);
void CkHttp_getProxyLogin(HCkHttp handle, HCkString retval);
void CkHttp_putProxyLogin(HCkHttp handle, const char *newVal);
void CkHttp_getProxyPassword(HCkHttp handle, HCkString retval);
void CkHttp_putProxyPassword(HCkHttp handle, const char *newVal);
long CkHttp_getProxyPort(HCkHttp handle);
void CkHttp_putProxyPort(HCkHttp handle, long newVal);
long CkHttp_getReadTimeout(HCkHttp handle);
void CkHttp_putReadTimeout(HCkHttp handle, long newVal);
void CkHttp_getReferer(HCkHttp handle, HCkString retval);
void CkHttp_putReferer(HCkHttp handle, const char *newVal);
void CkHttp_getRequiredContentType(HCkHttp handle, HCkString retval);
void CkHttp_putRequiredContentType(HCkHttp handle, const char *newVal);
BOOL CkHttp_getSaveCookies(HCkHttp handle);
void CkHttp_putSaveCookies(HCkHttp handle, BOOL newVal);
BOOL CkHttp_getSendCookies(HCkHttp handle);
void CkHttp_putSendCookies(HCkHttp handle, BOOL newVal);
void CkHttp_getSslProtocol(HCkHttp handle, HCkString retval);
void CkHttp_putSslProtocol(HCkHttp handle, const char *newVal);
BOOL CkHttp_getUpdateCache(HCkHttp handle);
void CkHttp_putUpdateCache(HCkHttp handle, BOOL newVal);
BOOL CkHttp_getUseIEProxy(HCkHttp handle);
void CkHttp_putUseIEProxy(HCkHttp handle, BOOL newVal);
void CkHttp_getUserAgent(HCkHttp handle, HCkString retval);
void CkHttp_putUserAgent(HCkHttp handle, const char *newVal);
BOOL CkHttp_getUtf8(HCkHttp handle);
void CkHttp_putUtf8(HCkHttp handle, BOOL newVal);
void CkHttp_getVersion(HCkHttp handle, HCkString retval);
BOOL CkHttp_getWasRedirected(HCkHttp handle);
void CkHttp_AddCacheRoot(HCkHttp handle, const char *dir);
BOOL CkHttp_Download(HCkHttp handle, const char *url, const char *filename);
BOOL CkHttp_DownloadAppend(HCkHttp handle, const char *url, const char *filename);
BOOL CkHttp_GetCacheRoot(HCkHttp handle, int index, HCkString str);
BOOL CkHttp_GetCookieXml(HCkHttp handle, const char *domain, HCkString outStr);
void CkHttp_GetDomain(HCkHttp handle, const char *url, HCkString str);
BOOL CkHttp_GetRequestHeader(HCkHttp handle, const char *name, HCkString str);
void CkHttp_GetUrlPath(HCkHttp handle, const char *url, HCkString str);
BOOL CkHttp_HasRequestHeader(HCkHttp handle, const char *name);
BOOL CkHttp_IsUnlocked(HCkHttp handle);
HCkHttpResponse CkHttp_PostMime(HCkHttp handle, const char *url, const char *mime);
BOOL CkHttp_QuickGet(HCkHttp handle, const char *url, HCkByteData data);
BOOL CkHttp_QuickGetStr(HCkHttp handle, const char *url, HCkString str);
void CkHttp_RemoveRequestHeader(HCkHttp handle, const char *name);
BOOL CkHttp_RenderGet(HCkHttp handle, const char *url, HCkString outStr);
BOOL CkHttp_ResumeDownload(HCkHttp handle, const char *url, const char *filename);
BOOL CkHttp_SaveLastError(HCkHttp handle, const char *filename);
void CkHttp_SetRequestHeader(HCkHttp handle, const char *name, const char *value);
void CkHttp_SetSslClientCert(HCkHttp handle, HCkCert cert);
HCkHttpResponse CkHttp_SynchronousRequest(HCkHttp handle, const char *domain, long port, BOOL ssl, HCkHttpRequest req);
BOOL CkHttp_UnlockComponent(HCkHttp handle, const char *unlockCode);
BOOL CkHttp_UrlDecode(HCkHttp handle, const char *str, HCkString outStr);
BOOL CkHttp_UrlEncode(HCkHttp handle, const char *str, HCkString outStr);
const char *CkHttp_acceptCharset(HCkHttp handle);
const char *CkHttp_acceptLanguage(HCkHttp handle);
const char *CkHttp_ck_accept(HCkHttp handle);
const char *CkHttp_connection(HCkHttp handle);
const char *CkHttp_cookieDir(HCkHttp handle);
const char *CkHttp_finalRedirectUrl(HCkHttp handle);
const char *CkHttp_getCacheRoot(HCkHttp handle, int index);
const char *CkHttp_getCookieXml(HCkHttp handle, const char *domain);
const char *CkHttp_getDomain(HCkHttp handle, const char *url);
const char *CkHttp_getRequestHeader(HCkHttp handle, const char *name);
const char *CkHttp_getUrlPath(HCkHttp handle, const char *url);
const char *CkHttp_lastContentType(HCkHttp handle);
const char *CkHttp_lastErrorHtml(HCkHttp handle);
const char *CkHttp_lastErrorText(HCkHttp handle);
const char *CkHttp_lastErrorXml(HCkHttp handle);
const char *CkHttp_lastHeader(HCkHttp handle);
const char *CkHttp_lastModDate(HCkHttp handle);
const char *CkHttp_lastResponseHeader(HCkHttp handle);
const char *CkHttp_login(HCkHttp handle);
const char *CkHttp_password(HCkHttp handle);
const char *CkHttp_proxyDomain(HCkHttp handle);
const char *CkHttp_proxyLogin(HCkHttp handle);
const char *CkHttp_proxyPassword(HCkHttp handle);
const char *CkHttp_quickGetStr(HCkHttp handle, const char *url);
const char *CkHttp_referer(HCkHttp handle);
const char *CkHttp_renderGet(HCkHttp handle, const char *url);
const char *CkHttp_requiredContentType(HCkHttp handle);
const char *CkHttp_sslProtocol(HCkHttp handle);
const char *CkHttp_urlDecode(HCkHttp handle, const char *str);
const char *CkHttp_urlEncode(HCkHttp handle, const char *str);
const char *CkHttp_userAgent(HCkHttp handle);
const char *CkHttp_version(HCkHttp handle);
#endif

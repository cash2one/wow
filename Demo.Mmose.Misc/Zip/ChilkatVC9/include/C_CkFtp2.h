#ifndef _CkFtp2_H
#define _CkFtp2_H
#include "Chilkat_C.h"

HCkFtp2 CkFtp2_Create(void);
void CkFtp2_Dispose(HCkFtp2 handle);
void CkFtp2_getAccount(HCkFtp2 handle, HCkString retval);
void CkFtp2_putAccount(HCkFtp2 handle, const char *newVal);
long CkFtp2_getActivePortRangeEnd(HCkFtp2 handle);
void CkFtp2_putActivePortRangeEnd(HCkFtp2 handle, long newVal);
long CkFtp2_getActivePortRangeStart(HCkFtp2 handle);
void CkFtp2_putActivePortRangeStart(HCkFtp2 handle, long newVal);
unsigned long CkFtp2_getAllocateSize(HCkFtp2 handle);
void CkFtp2_putAllocateSize(HCkFtp2 handle, unsigned long newVal);
unsigned long CkFtp2_getAsyncBytesReceived(HCkFtp2 handle);
unsigned long CkFtp2_getAsyncBytesSent(HCkFtp2 handle);
BOOL CkFtp2_getAsyncFinished(HCkFtp2 handle);
void CkFtp2_getAsyncLog(HCkFtp2 handle, HCkString retval);
BOOL CkFtp2_getAsyncSuccess(HCkFtp2 handle);
BOOL CkFtp2_getAuthSsl(HCkFtp2 handle);
void CkFtp2_putAuthSsl(HCkFtp2 handle, BOOL newVal);
BOOL CkFtp2_getAuthTls(HCkFtp2 handle);
void CkFtp2_putAuthTls(HCkFtp2 handle, BOOL newVal);
BOOL CkFtp2_getAutoFeat(HCkFtp2 handle);
void CkFtp2_putAutoFeat(HCkFtp2 handle, BOOL newVal);
BOOL CkFtp2_getAutoSyst(HCkFtp2 handle);
void CkFtp2_putAutoSyst(HCkFtp2 handle, BOOL newVal);
BOOL CkFtp2_getAutoXcrc(HCkFtp2 handle);
void CkFtp2_putAutoXcrc(HCkFtp2 handle, BOOL newVal);
long CkFtp2_getBandwidthThrottleDown(HCkFtp2 handle);
void CkFtp2_putBandwidthThrottleDown(HCkFtp2 handle, long newVal);
long CkFtp2_getBandwidthThrottleUp(HCkFtp2 handle);
void CkFtp2_putBandwidthThrottleUp(HCkFtp2 handle, long newVal);
long CkFtp2_getConnectFailReason(HCkFtp2 handle);
long CkFtp2_getConnectTimeout(HCkFtp2 handle);
void CkFtp2_putConnectTimeout(HCkFtp2 handle, long newVal);
BOOL CkFtp2_getConnectVerified(HCkFtp2 handle);
long CkFtp2_getCrlfMode(HCkFtp2 handle);
void CkFtp2_putCrlfMode(HCkFtp2 handle, long newVal);
void CkFtp2_getDirListingCharset(HCkFtp2 handle, HCkString retval);
void CkFtp2_putDirListingCharset(HCkFtp2 handle, const char *newVal);
long CkFtp2_getDownloadRate(HCkFtp2 handle);
BOOL CkFtp2_getHasModeZ(HCkFtp2 handle);
long CkFtp2_getHeartbeatMs(HCkFtp2 handle);
void CkFtp2_putHeartbeatMs(HCkFtp2 handle, long newVal);
void CkFtp2_getHostname(HCkFtp2 handle, HCkString retval);
void CkFtp2_putHostname(HCkFtp2 handle, const char *newVal);
long CkFtp2_getIdleTimeoutMs(HCkFtp2 handle);
void CkFtp2_putIdleTimeoutMs(HCkFtp2 handle, long newVal);
BOOL CkFtp2_getIsConnected(HCkFtp2 handle);
BOOL CkFtp2_getKeepSessionLog(HCkFtp2 handle);
void CkFtp2_putKeepSessionLog(HCkFtp2 handle, BOOL newVal);
void CkFtp2_getLastErrorHtml(HCkFtp2 handle, HCkString retval);
void CkFtp2_getLastErrorText(HCkFtp2 handle, HCkString retval);
void CkFtp2_getLastErrorXml(HCkFtp2 handle, HCkString retval);
void CkFtp2_getListPattern(HCkFtp2 handle, HCkString retval);
void CkFtp2_putListPattern(HCkFtp2 handle, const char *newVal);
BOOL CkFtp2_getLoginVerified(HCkFtp2 handle);
long CkFtp2_getNumFilesAndDirs(HCkFtp2 handle);
BOOL CkFtp2_getPartialTransfer(HCkFtp2 handle);
BOOL CkFtp2_getPassive(HCkFtp2 handle);
void CkFtp2_putPassive(HCkFtp2 handle, BOOL newVal);
BOOL CkFtp2_getPassiveUseHostAddr(HCkFtp2 handle);
void CkFtp2_putPassiveUseHostAddr(HCkFtp2 handle, BOOL newVal);
void CkFtp2_getPassword(HCkFtp2 handle, HCkString retval);
void CkFtp2_putPassword(HCkFtp2 handle, const char *newVal);
long CkFtp2_getPort(HCkFtp2 handle);
void CkFtp2_putPort(HCkFtp2 handle, long newVal);
long CkFtp2_getProgressMonSize(HCkFtp2 handle);
void CkFtp2_putProgressMonSize(HCkFtp2 handle, long newVal);
void CkFtp2_getProxyHostname(HCkFtp2 handle, HCkString retval);
void CkFtp2_putProxyHostname(HCkFtp2 handle, const char *newVal);
long CkFtp2_getProxyMethod(HCkFtp2 handle);
void CkFtp2_putProxyMethod(HCkFtp2 handle, long newVal);
void CkFtp2_getProxyPassword(HCkFtp2 handle, HCkString retval);
void CkFtp2_putProxyPassword(HCkFtp2 handle, const char *newVal);
long CkFtp2_getProxyPort(HCkFtp2 handle);
void CkFtp2_putProxyPort(HCkFtp2 handle, long newVal);
void CkFtp2_getProxyUsername(HCkFtp2 handle, HCkString retval);
void CkFtp2_putProxyUsername(HCkFtp2 handle, const char *newVal);
long CkFtp2_getReadTimeout(HCkFtp2 handle);
void CkFtp2_putReadTimeout(HCkFtp2 handle, long newVal);
BOOL CkFtp2_getRequireSslCertVerify(HCkFtp2 handle);
void CkFtp2_putRequireSslCertVerify(HCkFtp2 handle, BOOL newVal);
BOOL CkFtp2_getRestartNext(HCkFtp2 handle);
void CkFtp2_putRestartNext(HCkFtp2 handle, BOOL newVal);
void CkFtp2_getSessionLog(HCkFtp2 handle, HCkString retval);
BOOL CkFtp2_getSsl(HCkFtp2 handle);
void CkFtp2_putSsl(HCkFtp2 handle, BOOL newVal);
BOOL CkFtp2_getSslServerCertVerified(HCkFtp2 handle);
long CkFtp2_getUploadRate(HCkFtp2 handle);
void CkFtp2_getUsername(HCkFtp2 handle, HCkString retval);
void CkFtp2_putUsername(HCkFtp2 handle, const char *newVal);
BOOL CkFtp2_getUtf8(HCkFtp2 handle);
void CkFtp2_putUtf8(HCkFtp2 handle, BOOL newVal);
void CkFtp2_getVersion(HCkFtp2 handle, HCkString retval);
BOOL CkFtp2_AppendFile(HCkFtp2 handle, const char *localFilename, const char *remoteFilename);
BOOL CkFtp2_AppendFileFromBinaryData(HCkFtp2 handle, const char *remoteFilename, HCkByteData binaryData);
BOOL CkFtp2_AppendFileFromTextData(HCkFtp2 handle, const char *remoteFilename, const char *textData);
void CkFtp2_AsyncAbort(HCkFtp2 handle);
BOOL CkFtp2_AsyncAppendFileStart(HCkFtp2 handle, const char *localFilename, const char *remoteFilename);
BOOL CkFtp2_AsyncGetFileStart(HCkFtp2 handle, const char *remoteFilename, const char *localFilename);
BOOL CkFtp2_AsyncPutFileStart(HCkFtp2 handle, const char *localFilename, const char *remoteFilename);
BOOL CkFtp2_ChangeRemoteDir(HCkFtp2 handle, const char *relativeDirPath);
BOOL CkFtp2_ClearControlChannel(HCkFtp2 handle);
void CkFtp2_ClearDirCache(HCkFtp2 handle);
void CkFtp2_ClearSessionLog(HCkFtp2 handle);
BOOL CkFtp2_Connect(HCkFtp2 handle);
BOOL CkFtp2_ConvertToTls(HCkFtp2 handle);
BOOL CkFtp2_CreatePlan(HCkFtp2 handle, const char *localDir, HCkString str);
BOOL CkFtp2_CreateRemoteDir(HCkFtp2 handle, const char *dir);
long CkFtp2_DeleteMatching(HCkFtp2 handle, const char *remotePattern);
BOOL CkFtp2_DeleteRemoteFile(HCkFtp2 handle, const char *filename);
BOOL CkFtp2_DeleteTree(HCkFtp2 handle);
int CkFtp2_DetermineProxyMethod(HCkFtp2 handle);
BOOL CkFtp2_DetermineSettings(HCkFtp2 handle, HCkString xmlReport);
BOOL CkFtp2_DirTreeXml(HCkFtp2 handle, HCkString strXml);
BOOL CkFtp2_Disconnect(HCkFtp2 handle);
BOOL CkFtp2_DownloadTree(HCkFtp2 handle, const char *localRoot);
BOOL CkFtp2_Feat(HCkFtp2 handle, HCkString sOut);
BOOL CkFtp2_GetCreateTime(HCkFtp2 handle, long index, SYSTEMTIME *sysTime);
BOOL CkFtp2_GetCreateTimeByName(HCkFtp2 handle, const char *filename, SYSTEMTIME *sysTime);
BOOL CkFtp2_GetCurrentRemoteDir(HCkFtp2 handle, HCkString str);
BOOL CkFtp2_GetFile(HCkFtp2 handle, const char *remoteFilename, const char *localFilename);
BOOL CkFtp2_GetFilename(HCkFtp2 handle, long index, HCkString str);
BOOL CkFtp2_GetIsDirectory(HCkFtp2 handle, long index);
BOOL CkFtp2_GetIsSymbolicLink(HCkFtp2 handle, long index);
BOOL CkFtp2_GetLastAccessTime(HCkFtp2 handle, long index, SYSTEMTIME *sysTime);
BOOL CkFtp2_GetLastAccessTimeByName(HCkFtp2 handle, const char *filename, SYSTEMTIME *sysTime);
BOOL CkFtp2_GetLastModifiedTime(HCkFtp2 handle, long index, SYSTEMTIME *sysTime);
BOOL CkFtp2_GetLastModifiedTimeByName(HCkFtp2 handle, const char *filename, SYSTEMTIME *sysTime);
BOOL CkFtp2_GetRemoteFileBinaryData(HCkFtp2 handle, const char *remoteFilename, HCkByteData data);
BOOL CkFtp2_GetRemoteFileTextC(HCkFtp2 handle, const char *remoteFilename, const char *charset, HCkString str);
BOOL CkFtp2_GetRemoteFileTextData(HCkFtp2 handle, const char *remoteFilename, HCkString str);
long CkFtp2_GetSize(HCkFtp2 handle, long index);
long CkFtp2_GetSizeByName(HCkFtp2 handle, const char *filname);
BOOL CkFtp2_GetSizeStr(HCkFtp2 handle, long index, HCkString str);
HCkCert CkFtp2_GetSslServerCert(HCkFtp2 handle);
BOOL CkFtp2_GetTextDirListing(HCkFtp2 handle, const char *pattern, HCkString strRawListing);
BOOL CkFtp2_GetXmlDirListing(HCkFtp2 handle, const char *pattern, HCkString strXmlListing);
BOOL CkFtp2_IsUnlocked(HCkFtp2 handle);
long CkFtp2_MGetFiles(HCkFtp2 handle, const char *remotePattern, const char *localDir);
long CkFtp2_MPutFiles(HCkFtp2 handle, const char *pattern);
BOOL CkFtp2_Noop(HCkFtp2 handle);
BOOL CkFtp2_PutFile(HCkFtp2 handle, const char *localFilename, const char *remoteFilename);
BOOL CkFtp2_PutFileFromBinaryData(HCkFtp2 handle, const char *remoteFilename, HCkByteData binaryData);
BOOL CkFtp2_PutFileFromTextData(HCkFtp2 handle, const char *remoteFilename, const char *textData);
BOOL CkFtp2_PutPlan(HCkFtp2 handle, const char *planUtf8, const char *planLogFilename);
BOOL CkFtp2_PutTree(HCkFtp2 handle, const char *localDir);
BOOL CkFtp2_Quote(HCkFtp2 handle, const char *cmd);
BOOL CkFtp2_RemoveRemoteDir(HCkFtp2 handle, const char *dir);
BOOL CkFtp2_RenameRemoteFile(HCkFtp2 handle, const char *existingFilename, const char *newFilename);
BOOL CkFtp2_SaveLastError(HCkFtp2 handle, const char *filename);
BOOL CkFtp2_SendCommand(HCkFtp2 handle, const char *cmd, HCkString reply);
BOOL CkFtp2_SetModeZ(HCkFtp2 handle);
void CkFtp2_SetOldestDate(HCkFtp2 handle, SYSTEMTIME *oldestDateTime);
void CkFtp2_SetSslCertRequirement(HCkFtp2 handle, const char *name, const char *value);
void CkFtp2_SetSslClientCert(HCkFtp2 handle, HCkCert cert);
BOOL CkFtp2_SetTypeAscii(HCkFtp2 handle);
BOOL CkFtp2_SetTypeBinary(HCkFtp2 handle);
BOOL CkFtp2_Site(HCkFtp2 handle, const char *params);
void CkFtp2_SleepMs(HCkFtp2 handle, int millisec);
BOOL CkFtp2_Stat(HCkFtp2 handle, HCkString sOut);
BOOL CkFtp2_SyncLocalTree(HCkFtp2 handle, const char *localRoot, int mode);
BOOL CkFtp2_SyncRemoteTree(HCkFtp2 handle, const char *localRoot, int mode);
BOOL CkFtp2_Syst(HCkFtp2 handle, HCkString sOut);
BOOL CkFtp2_UnlockComponent(HCkFtp2 handle, const char *code);
const char *CkFtp2_account(HCkFtp2 handle);
const char *CkFtp2_asyncLog(HCkFtp2 handle);
const char *CkFtp2_ck_stat(HCkFtp2 handle);
const char *CkFtp2_createPlan(HCkFtp2 handle, const char *localDir);
const char *CkFtp2_determineSettings(HCkFtp2 handle);
const char *CkFtp2_dirListingCharset(HCkFtp2 handle);
const char *CkFtp2_dirTreeXml(HCkFtp2 handle);
const char *CkFtp2_feat(HCkFtp2 handle);
const char *CkFtp2_getCurrentRemoteDir(HCkFtp2 handle);
const char *CkFtp2_getFilename(HCkFtp2 handle, long index);
const char *CkFtp2_getRemoteFileTextC(HCkFtp2 handle, const char *remoteFilename, const char *charset);
const char *CkFtp2_getRemoteFileTextData(HCkFtp2 handle, const char *remoteFilename);
const char *CkFtp2_getSizeStr(HCkFtp2 handle, long index);
const char *CkFtp2_getTextDirListing(HCkFtp2 handle, const char *pattern);
const char *CkFtp2_getXmlDirListing(HCkFtp2 handle, const char *pattern);
const char *CkFtp2_hostname(HCkFtp2 handle);
const char *CkFtp2_lastErrorHtml(HCkFtp2 handle);
const char *CkFtp2_lastErrorText(HCkFtp2 handle);
const char *CkFtp2_lastErrorXml(HCkFtp2 handle);
const char *CkFtp2_listPattern(HCkFtp2 handle);
const char *CkFtp2_password(HCkFtp2 handle);
const char *CkFtp2_proxyHostname(HCkFtp2 handle);
const char *CkFtp2_proxyPassword(HCkFtp2 handle);
const char *CkFtp2_proxyUsername(HCkFtp2 handle);
const char *CkFtp2_sendCommand(HCkFtp2 handle, const char *cmd);
const char *CkFtp2_sessionLog(HCkFtp2 handle);
const char *CkFtp2_syst(HCkFtp2 handle);
const char *CkFtp2_username(HCkFtp2 handle);
const char *CkFtp2_version(HCkFtp2 handle);
bool CkFtp2_SetRemoteFileDateTime(HCkFtp2 handle, SYSTEMTIME *dateTime, const char *filename);
#endif

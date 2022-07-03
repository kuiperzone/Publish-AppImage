#!/bin/bash
# This is a dummy script only. It does nothing except output information.
# Ensure that it has executable permission and specify the POST_PUBLISH config parameter to point at it.

echo "DUMMY POST_PUBLISH SCRIPT"
echo "APP_MAIN: ${APP_MAIN}"
echo "APP_ID: ${APP_ID}"
echo "APP_VERSION: ${APP_VERSION}"
echo "VERSION: ${VERSION}"

echo "ISO_DATE: ${ISO_DATE}"
echo "DOTNET_RID: ${DOTNET_RID}"
echo "PKG_KIND: ${PKG_KIND}"
echo "APPDIR_ROOT: ${APPDIR_ROOT}"
echo "APPDIR_USR: ${APPDIR_USR}"
echo "APPDIR_BIN: ${APPDIR_BIN}"
echo "APPRUN_TARGET: ${APPRUN_TARGET}"
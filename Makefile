publish_mac_intel: publish_for_osx-x64
publish_mac_silicon: publish_for_osx-arm64
publish_win: publish_for_win-x64
publish_linux: publish_for_linux-x64

install_mac_intel: publish_mac_intel
install_mac_intel: install_non_windows_osx-x64

install_mac_silicon: publish_mac_silicon
install_mac_silicon: install_non_windows_osx-arm64

publish_for_%:
	@echo "Publishing for $*"
	@dotnet publish Yarr \
	-verbosity:quiet \
	-p:RuntimeIdentifier=${*} \
	-p:SelfContained=true \
	-p:PublishSingleFile=true \
	-p:IncludeNativeLibrariesForSelfExtract=true \
	-p:PublishTrimmed=false \
	-p:DebugType=embedded \
	-p:EnableCompressionInSingleFile=true \
	--output publish/${*}/yarr
	@echo "Published to publish/${*}/yarr"

install_non_windows_%:
	@echo "Installing for $*"
	cp publish/${*}/yarr/yarr /usr/local/bin/yarr

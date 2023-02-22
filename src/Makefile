XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/../external/IQKeyboardManager
PROJECT=$(PROJECT_ROOT)/IQKeyboardManager.xcodeproj
BUILD_ROOT=$(PROJECT_ROOT)/build
TARGET_IOS=IQKeyboardManager
TARGET_TVOS=IQKeyboardManager
PROJECTNAME=IQKeyboardManager
OUTPUT=$(ROOT)/Build
FRAMEWORK_PATH=Products/Library/Frameworks/IQKeyboardManager.framework
FRAMEWORKS=$(ROOT)/Frameworks
FRAMEWORKS_IOS=$(ROOT)/Frameworks/ios

all: iossimulator iosdevice xcframework dotnet

build: iossimulator iosdevice xcframework

pack: build nuget

iossimulator:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_IOS) -destination "generic/platform=iOS Simulator" -archivePath $(BUILD_ROOT)/simulator.xcarchive -sdk iphonesimulator SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

iosdevice:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_IOS) -destination "generic/platform=iOS" -archivePath $(BUILD_ROOT)/iOS.xcarchive -sdk iphoneos SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcframework:
	rm -rf $(BUILD_ROOT)/IQKeyboardManager.xcframework
	$(XBUILD) -create-xcframework -framework $(BUILD_ROOT)/simulator.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/iOS.xcarchive/$(FRAMEWORK_PATH) -output $(BUILD_ROOT)/IQKeyboardManager.xcframework
	rm -rf $(FRAMEWORKS)
	mkdir -p $(FRAMEWORKS)
	cp -R $(BUILD_ROOT)/ $(FRAMEWORKS)

dotnet:
	dotnet build -c Release

nuget:
	dotnet pack --configuration Release
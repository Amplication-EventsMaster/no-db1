import { Module } from "@nestjs/common";
import { PackageService } from "./package.service";
import { PackageController } from "./package.controller";
import { PackageResolver } from "./package.resolver";

@Module({
  controllers: [PackageController],
  providers: [PackageService, PackageResolver],
  exports: [PackageService],
})
export class PackageModule {}

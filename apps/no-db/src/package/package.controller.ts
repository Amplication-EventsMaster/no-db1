import * as common from "@nestjs/common";
import * as swagger from "@nestjs/swagger";
import * as errors from "../errors";
import { PackageService } from "./package.service";
import { Package } from "./Package";

@swagger.ApiTags("packages")
@common.Controller("packages")
export class PackageController {
  constructor(protected readonly service: PackageService) {}

  @common.Get("/:id/process-pacakge")
  @swagger.ApiOkResponse({
    type: Package
  })
  @swagger.ApiNotFoundResponse({
    type: errors.NotFoundException
  })
  @swagger.ApiForbiddenResponse({
    type: errors.ForbiddenException
  })
  async ProcessPacakge(
    @common.Body()
    body: string
  ): Promise<Package[]> {
        return this.service.ProcessPacakge(body);
      }
}

import * as graphql from "@nestjs/graphql";
import { Package } from "./Package";
import { PackageService } from "./package.service";

export class PackageResolver {
  constructor(protected readonly service: PackageService) {}

  @graphql.Query(() => [Package])
  async ProcessPacakge(
    @graphql.Args("args")
    args: string
  ): Promise<Package[]> {
    return this.service.ProcessPacakge(args);
  }
}
